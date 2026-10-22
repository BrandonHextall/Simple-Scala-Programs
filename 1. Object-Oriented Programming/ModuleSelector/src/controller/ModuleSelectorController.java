package controller;

import java.io.File;
import java.io.FileInputStream;
import java.io.FileNotFoundException;
import java.io.FileOutputStream;
import java.io.IOException;
import java.io.ObjectInputStream;
import java.io.ObjectOutputStream;
import java.util.Collection;

import javafx.event.ActionEvent;
import javafx.event.EventHandler;
import javafx.scene.control.Alert;
import javafx.stage.FileChooser;
import model.Block;
import model.Course;
import model.Module;
import model.StudentProfile;
import view.ModuleSelectorRootPane;
import view.CreateStudentProfilePane;
import view.ModuleSelectorMenuBar;
import view.OverviewSelectionPane;
import view.ReserveModulesPane;
import view.SelectModulesPane;

public class ModuleSelectorController {

	//fields to be used throughout class
	private ModuleSelectorRootPane view;
	private StudentProfile model;
	
	private CreateStudentProfilePane cspp;
	private ModuleSelectorMenuBar msmb;
	private SelectModulesPane smp;
	private ReserveModulesPane rmp;
	private OverviewSelectionPane osp;

	public ModuleSelectorController(ModuleSelectorRootPane view, StudentProfile model) {
		//initialise view and model fields
		this.view = view;
		this.model = model;
		
		//initialise view subcontainer fields
		cspp = view.getCreateStudentProfilePane();
		msmb = view.getModuleSelectorMenuBar();
		smp = view.getSelectModulesPane();
		rmp = view.getReserveModulesPane();
		osp = view.getOverviewSelectionPane();
		

		//add courses to combobox in create student profile pane using the createModulesAndCourses helper method below
		cspp.addCourseDataToComboBox(createModulesAndCourses());

		//attach event handlers to view using private helper method
		this.attachEventHandlers();
	}

	
	//helper method - used to attach event handlers
	private void attachEventHandlers() {
		//attach an event handler to the create student profile pane
		cspp.addCreateStudentProfileHandler(new CreateStudentProfileHandler());
		
		//attach event handlers to module selection pane
		smp.addAddModuleHandler(new CreateAddModuleHandler());
		smp.addRemModuleHandler(new CreateRemModuleHandler());
		smp.addResetModuleHandler(new CreateResetModuleHandler());
		smp.addSubmitModuleHandler(new CreateSubmitModuleHandler());
		
		//attach event handlers to reserve module selection pane
		rmp.addAddResModuleHandler(new CreateAddReserveModuleHandler());
		rmp.addRemResModuleHandler(new CreateRemReserveModuleHandler());
		rmp.addConResModuleHandler(new CreateConReserveModuleHandler());
		
		//attach event handlers to save overview
		osp.addSaveOverviewHandler(new CreateSaveHandler());
		
		//attach event handler to save file menu bar
		msmb.addSaveHandler(new CreateSaveHandler());
		msmb.addLoadHandler(new CreateLoadHandler());
		
		//attach event handler to about button on menu bar
		msmb.addAboutHandler(new CreateAboutHandler());
		
		//attach an event handler to the menu bar that closes the application
		msmb.addExitHandler(e -> System.exit(0));
		
	}
	
	//event handler, which can be used for creating a profile
	private class CreateStudentProfileHandler implements EventHandler<ActionEvent> {
		public void handle(ActionEvent e) {
			//collect inputs
			model.setStudentCourse(cspp.getSelectedCourse());
			model.setStudentEmail(cspp.getStudentEmail());
			model.setStudentName(cspp.getStudentName());
			model.setStudentPnumber(cspp.getStudentPnumber());
			model.setSubmissionDate(cspp.getStudentDate());
			//displayDefaultModules();
			resetModules();
		}
	}
	
	//event handler which can be used for adding modules to Block3/4
	private class CreateAddModuleHandler implements EventHandler<ActionEvent> {
		public void handle(ActionEvent e) {
			var unselected = smp.getUnsBlock34List();
			var selected = smp.getSelBlock34List();
			var selectedItem = unselected.getSelectionModel().getSelectedItem();
			if (selectedItem != null) {				
				selected.getItems().add(selectedItem);
				unselected.getItems().remove(selectedItem);
			}
			displayTotalCredits();
		}
	}
	
	//event handler which can be used for removing modules from Block3/4
	private class CreateRemModuleHandler implements EventHandler<ActionEvent> {
		public void handle(ActionEvent e) {
			var unselected = smp.getUnsBlock34List();
			var selected = smp.getSelBlock34List();
			var selectedItem = selected.getSelectionModel().getSelectedItem();
			if (selectedItem != null && !selectedItem.isMandatory()) {				
				unselected.getItems().add(selectedItem);
				selected.getItems().remove(selectedItem);
			}
			displayTotalCredits();
		}
	}
	
	//event handler which can be used to reset selected modules
	private class CreateResetModuleHandler implements EventHandler<ActionEvent> {
		public void handle(ActionEvent e) {
			//displayDefaultModules();
			resetModules();
		}
	}
	
	//event handler which can be used to submit selected modules
	private class CreateSubmitModuleHandler implements EventHandler<ActionEvent> {
		public void handle(ActionEvent e) {
				model.clearSelectedModules();
			rmp.getUns34Modules().getItems().clear();
			rmp.getRes34Modules().getItems().clear();
			model.clearReservedModules();
			if (smp.getTotalCredits() == 120) {
				smp.getSelBlock1List().getItems().forEach(m -> model.addSelectedModule(m));
				smp.getSelBlock2List().getItems().forEach(m -> model.addSelectedModule(m));
				smp.getSelBlock34List().getItems().forEach(m -> model.addSelectedModule(m));
				smp.getUnsBlock34List().getItems().forEach(m -> rmp.getUns34Modules().getItems().add(m));
			}
		}
	}
	
	//event handler which can be used to add a reserve module
	private class CreateAddReserveModuleHandler implements EventHandler<ActionEvent> {
		public void handle(ActionEvent e) {
			Module module = rmp.getUns34Modules().getSelectionModel().getSelectedItem();
			if (module instanceof Module && rmp.getRes34Modules().getItems().size() < 1) {				
				rmp.getRes34Modules().getItems().add(module);
				rmp.getUns34Modules().getItems().remove(module);
			}
		}
	}
	
	//event handler which can be used to remove a reserve module
	private class CreateRemReserveModuleHandler implements EventHandler<ActionEvent> {
		public void handle(ActionEvent e) {
			Module module = rmp.getRes34Modules().getSelectionModel().getSelectedItem();
			if (module instanceof Module) {
				rmp.getRes34Modules().getItems().remove(module);
				rmp.getUns34Modules().getItems().add(module);
			}
		}
	}
	
	//event handler which can be used to confirm reserved modules
	private class CreateConReserveModuleHandler implements EventHandler<ActionEvent> {
		public void handle(ActionEvent e) {
			if (rmp.getRes34Modules().getItems().size() == 1) {
				model.clearReservedModules();
				rmp.getRes34Modules().getItems().forEach(m -> System.out.println(m));
				rmp.getRes34Modules().getItems().forEach(m -> model.addReservedModule(m));
				loadStudentDetails();
			}
		}
	}
	
	//event handler which can be used to save module overview and menu bar
	private class CreateSaveHandler implements EventHandler<ActionEvent> {
		public void handle(ActionEvent e) {
			FileChooser chooser = new FileChooser();
			chooser.setTitle("Save");
			chooser.setInitialFileName("studentData.bin");
			File file = chooser.showSaveDialog(null);
			try (ObjectOutputStream oos = new ObjectOutputStream(new FileOutputStream(file))) {
				oos.writeObject(model);
			} catch (FileNotFoundException e1) {
				// TODO Auto-generated catch block
				e1.printStackTrace();
			} catch (IOException e1) {
				// TODO Auto-generated catch block
				e1.printStackTrace();
			}
		}
	}
	
	private class CreateAboutHandler implements EventHandler<ActionEvent> {
		public void handle(ActionEvent e) {
			Alert about = new Alert(Alert.AlertType.INFORMATION);
			about.setTitle("About");
			about.setHeaderText("Module Selector");
			about.setContentText("This app allows you to enter your student details - including your student P-number, course, name, and email address - and select your desired modules as well as reserve any unselected modules.\n\nYou are also able to save and load a profile to and from your device for ease of use.");
			about.showAndWait();
		}
	}
	
	//event handler which can be used to load student data
	private class CreateLoadHandler implements EventHandler<ActionEvent> {
		public void handle(ActionEvent e) {
			smp.resetModules();
			FileChooser chooser = new FileChooser();
			chooser.setTitle("Load");
			File file = chooser.showOpenDialog(null);
			try (ObjectInputStream ois = new ObjectInputStream(new FileInputStream(file))) {
				StudentProfile loaded = (StudentProfile) ois.readObject();
				model = loaded;
				cspp.setStudentPnumber(model.getStudentPnumber());
		        cspp.setStudentDate(model.getSubmissionDate());
		        cspp.setStudentEmail(model.getStudentEmail());
		        cspp.setStudentName(model.getStudentName());
		        cspp.setSelectedCourse(model.getStudentCourse());
		        System.out.println(cspp.getSelectedCourse());
		        model.getAllSelectedModules().forEach(m -> {
		        	switch (m.getRunPlan()) {
		        	case Block.BLOCK_1:
		        		smp.getSelBlock1List().getItems().add(m);
		        		break;
		        	case Block.BLOCK_2:
		        		smp.getSelBlock2List().getItems().add(m);
		        		break;
		        	case Block.BLOCK_3_4:
		        		smp.getSelBlock34List().getItems().add(m);
		        		break;
		        	}
		        });
	        	cspp.getSelectedCourse().getAllModulesOnCourse().forEach(m -> {
	        		if (!model.getAllSelectedModules().contains(m)) {
	        			if (m.getRunPlan() == Block.BLOCK_3_4) {
	        				smp.getUnsBlock34List().getItems().add(m);
	        				if (model.getAllReservedModules().contains(m)) {
	        					rmp.getRes34Modules().getItems().add(m);
	        				} else rmp.getUns34Modules().getItems().add(m);
	        			}
	        		}
	        	});
	            displayTotalCredits();
				loadStudentDetails();
			} catch (IOException | ClassNotFoundException e1) {
				e1.printStackTrace();
			}
		}
	}
    
    //Loads student details
    public void loadStudentDetails() {
    	//adding student details
    	StringBuilder stuDet = new StringBuilder();
    	stuDet.append("Name: " + model.getStudentName().getFirstName() + " " + model.getStudentName().getFamilyName() + "\n");
    	stuDet.append("Pnumber: " + model.getStudentPnumber() + "\n");
    	stuDet.append("Email: " + model.getStudentEmail() + "\n");
    	stuDet.append("Date Submitted: " + model.getSubmissionDate() + "\n");
    	stuDet.append("Course: " + model.getStudentCourse());
    	osp.getProfile().setText(stuDet.toString());
    	
    	//displaying selected modules
    	StringBuilder modules = new StringBuilder("Selected modules:\n============\n");
    	model.getAllSelectedModules().forEach(m -> {
    		modules.append("Module Code: " + m.getModuleCode() + ", ");
    		modules.append("Module Name: " + m.getModuleName() + ", \n");
    		modules.append("Credits: " + m.getModuleCredits() + ", ");
    		modules.append("Mandatory: " + (m.isMandatory() ? "yes" : "no") + ", ");
    		modules.append("Block: " + (m.getRunPlan() == Block.BLOCK_1 ? "Block 1" : m.getRunPlan() == Block.BLOCK_2 ? "Block 2" : "Block 3/4") + "\n\n");
    		osp.getSelmod().setText(modules.toString());
    	});
    	
    	StringBuilder reserve = new StringBuilder("Reserve modules:\n============\n");
    	model.getAllReservedModules().forEach(r -> {
    		reserve.append("Module Code: " + r.getModuleCode() + ", ");
    		reserve.append("Module Name: " + r.getModuleName() + ", \n");
    		reserve.append("Credits: " + r.getModuleCredits() + ", ");
    		reserve.append("Mandatory: " + (r.isMandatory() ? "yes" : "no") + ", ");
    		reserve.append("Block: " + (r.getRunPlan() == Block.BLOCK_1 ? "Block 1" : r.getRunPlan() == Block.BLOCK_2 ? "Block 2" : "Block 3/4") + "\n\n");
    	});
    	osp.getResmod().setText(reserve.toString());
    }
	
	private void resetModules() {
        smp.getSelBlock1List().getItems().clear();
        smp.getSelBlock2List().getItems().clear();
        smp.getSelBlock34List().getItems().clear();
        smp.getUnsBlock34List().getItems().clear();
        model.clearReservedModules();
        model.clearSelectedModules();
        if (model.getStudentCourse() != null) {
	        Collection<Module> modules = model.getStudentCourse().getAllModulesOnCourse();
	        modules.forEach(m -> {
	            switch(m.getRunPlan()) {
	            case Block.BLOCK_1:
	                smp.getSelBlock1List().getItems().add(m);
	                break;
	            case Block.BLOCK_2:
	                smp.getSelBlock2List().getItems().add(m);
	                break;
	            case Block.BLOCK_3_4:
	                if (m.isMandatory()) {
	                    smp.getSelBlock34List().getItems().add(m);
	                } else smp.getUnsBlock34List().getItems().add(m);
	                break;
	            }
	        });
        }
        displayTotalCredits();
    }
	
	//displaying total credits for mandatory modules
	public void displayTotalCredits() {
		int[] totalCredits = {0};
		smp.getSelBlock1List().getItems().forEach(m -> {
			totalCredits[0] += m.getModuleCredits();
		});
		smp.getSelBlock2List().getItems().forEach(m -> {
			totalCredits[0] += m.getModuleCredits();
		});
		smp.getSelBlock34List().getItems().forEach(m -> {
			totalCredits[0] += m.getModuleCredits();
		});
		smp.setCreditDisplay(totalCredits[0] + "");
	}

	//helper method - creates modules and course data and returns courses within an array
	private Course[] createModulesAndCourses() {
		Module ctec3701 = new Module("CTEC3701", "Software Development: Methods & Standards", 30, true, Block.BLOCK_1);

		Module ctec3702 = new Module("CTEC3702", "Big Data and Machine Learning", 30, true, Block.BLOCK_2);
		Module ctec3703 = new Module("CTEC3703", "Mobile App Development and Big Data", 30, true, Block.BLOCK_2);

		Module ctec3451 = new Module("CTEC3451", "Development Project", 30, true, Block.BLOCK_3_4);

		Module ctec3704 = new Module("CTEC3704", "Functional Programming", 30, false, Block.BLOCK_3_4);
		Module ctec3705 = new Module("CTEC3705", "Advanced Web Development", 30, false, Block.BLOCK_3_4);

		Module imat3711 = new Module("IMAT3711", "Privacy and Data Protection", 30, false, Block.BLOCK_3_4);
		Module imat3722 = new Module("IMAT3722", "Fuzzy Logic and Inference Systems", 30, false, Block.BLOCK_3_4);

		Module ctec3706 = new Module("CTEC3706", "Embedded Systems and IoT", 30, false, Block.BLOCK_3_4);


		Course compSci = new Course("Computer Science");
		compSci.addModule(ctec3701);
		compSci.addModule(ctec3702);
		compSci.addModule(ctec3451);
		compSci.addModule(ctec3704);
		compSci.addModule(ctec3705);
		compSci.addModule(imat3711);
		compSci.addModule(imat3722);

		Course softEng = new Course("Software Engineering");
		softEng.addModule(ctec3701);
		softEng.addModule(ctec3703);
		softEng.addModule(ctec3451);
		softEng.addModule(ctec3704);
		softEng.addModule(ctec3705);
		softEng.addModule(ctec3706);

		Course[] courses = new Course[2];
		courses[0] = compSci;
		courses[1] = softEng;

		return courses;
	}

}
