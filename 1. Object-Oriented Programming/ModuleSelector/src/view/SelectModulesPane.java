package view;

import javafx.event.ActionEvent;
import javafx.event.EventHandler;
import javafx.geometry.Insets;
import javafx.geometry.Pos;
import javafx.scene.control.Button;
import javafx.scene.control.Label;
import javafx.scene.control.ListView;
import javafx.scene.control.TextField;
import javafx.scene.layout.GridPane;
import javafx.scene.layout.HBox;
import javafx.scene.layout.Priority;
import javafx.scene.layout.VBox;
import model.Module;

public class SelectModulesPane extends VBox {
	private TextField credits;
	private CourseView txts1, txtu34, txts2, txts34;
	private Button add34mod, rem34mod, reset, submit;
	
	public SelectModulesPane() {
		//styling
		this.setAlignment(Pos.CENTER);
		
		//create boxes
		GridPane 	s1box = new GridPane(),
					s2box = new GridPane(),
					ar34box = new GridPane(),
					u34box = new US34Box(),
					s34box = new US34Box(),
					btngrd = new GridPane();
		HBox 	hbox1 = new HBox(),
				hbox2 = new HBox(),
				hbox3 = new HBox();
		VBox u34con = new VBox();
		
		//create buttons
		add34mod = new Button("Add");
		rem34mod = new Button("Remove");
		reset = new Button("Reset");
		submit = new Button("Submit");
		
		
		//create labels
		Label 	s1title = new Label("Selected Block 1 Modules"),
				u34title = new Label("Unselected Block 3/4 Modules"),
				s2title = new Label("Selected Block 2 Modules"),
				s34title = new Label("Selected Block 3/4 Modules"),
				cctitle = new Label("Current Credits: "),
				ar34title = new Label("Block 3/4");
		
		
		//create text box (immutable)
		credits = new TextField();
		
		//create listviews
		txts1 = new CourseView();
		txtu34 = new CourseView();
		txts2 = new CourseView();
		txts34 = new CourseView();
		
		
		
		//sizing
		s1box.setPrefHeight(150);
		s2box.setPrefHeight(150);
		credits.setPrefSize(50, 20);
		reset.setPrefSize(100,  10);
		submit.setPrefSize(100,  15);
		
		//spacing
		hbox1.setSpacing(20);
		hbox2.setSpacing(20);
		hbox3.setSpacing(10);
		
		//padding
		hbox1.setPadding(new Insets(20, 20, 10, 20));
		hbox2.setPadding(new Insets(0, 20, 10, 20));
		ar34box.setPadding(new Insets(10, 30, 10, 10));
		btngrd.setPadding(new Insets(20, 20, 20, 20));
		cctitle.setPadding(new Insets(0, 5, 0, 0));
		
		//alignment
		hbox3.setAlignment(Pos.CENTER);
		btngrd.setAlignment(Pos.CENTER);
		ar34box.setAlignment(Pos.CENTER);
		cctitle.setAlignment(Pos.CENTER);
		
		//gap
		ar34box.setVgap(0);
		ar34box.setHgap(10);
		btngrd.setVgap(50);
		btngrd.setHgap(20);
		
		//setText
		credits.setText("0");
		//credits.setEditable(false);
		
		//scaling
		GridPane.setHgrow(txts1, Priority.ALWAYS);
		GridPane.setHgrow(txtu34, Priority.ALWAYS);
		GridPane.setHgrow(txts2, Priority.ALWAYS);
		GridPane.setHgrow(txts34, Priority.ALWAYS);
		GridPane.setVgrow(txts1, Priority.ALWAYS);
		GridPane.setVgrow(txtu34, Priority.ALWAYS);
		GridPane.setVgrow(txts2,  Priority.ALWAYS);
		GridPane.setVgrow(txts34, Priority.ALWAYS);
		GridPane.setHgrow(ar34box, Priority.ALWAYS);
		HBox.setHgrow(s1box, Priority.ALWAYS);
		HBox.setHgrow(u34con, Priority.ALWAYS);
		HBox.setHgrow(s2box, Priority.ALWAYS);
		HBox.setHgrow(s34box, Priority.ALWAYS);
		VBox.setVgrow(u34box, Priority.ALWAYS);
		VBox.setVgrow(hbox1, Priority.ALWAYS);
		VBox.setVgrow(hbox2, Priority.ALWAYS);
		HBox.setHgrow(ar34box, Priority.ALWAYS);
		
		
		//adding nodes to GridPane
		s1box.add(s1title, 0, 0);
		s1box.add(txts1, 0, 1);
		u34box.add(u34title, 0, 0);
		u34box.add(txtu34, 0, 1);
		ar34box.add(ar34title, 0, 0);
		ar34box.add(add34mod, 1, 0);
		ar34box.add(rem34mod, 2, 0);
		s2box.add(s2title, 0, 0);
		s2box.add(txts2, 0, 1);
		s34box.add(s34title, 0, 0);
		s34box.add(txts34, 0, 1);
		
		u34con.getChildren().addAll(u34box, ar34box);
		
		
		//adding GridPanes to main containers
		hbox1.getChildren().addAll(s1box, u34con);
		hbox2.getChildren().addAll(s2box, s34box);
		hbox3.getChildren().addAll(cctitle, credits);
		btngrd.add(reset, 0, 0);
		btngrd.add(submit, 1, 0);
		
		this.getChildren().addAll(hbox1, hbox2, hbox3, btngrd);
		
	}
	
	public class CourseView extends ListView<Module> {
		public CourseView() {
			super();
			this.setEditable(false);
			this.setPrefHeight(150);
		}
	}
	
	private class US34Box extends GridPane {
		public US34Box() {
			super();
			this.setPrefHeight(100);
		}
	}
	
	//get individual block ListView
	public ListView<Module> getSelBlock1List() {
		return txts1;
	}
	
	public ListView<Module> getSelBlock2List() {
		return txts2;
	}
	
	public ListView<Module> getSelBlock34List() {
		return txts34;
	}
	
	public ListView<Module> getUnsBlock34List() {
		return txtu34;
	}
	
	//get total credits
	public int getTotalCredits() {
		return Integer.parseInt(credits.getText());
	}
	
	//get credit display
	public TextField getCreditDisplay() {
		return credits;
	}
	
	public void setCreditDisplay(String text) {
		credits.setText(text);
	}
	
	public void resetModules() {
		txts1.getItems().clear();
		txts2.getItems().clear();
		txts34.getItems().clear();
		txtu34.getItems().clear();
	}
	
	//allows event handlers to be added
	public void addAddModuleHandler(EventHandler<ActionEvent> e) {
		add34mod.setOnAction(e);
	}
	
	public void addRemModuleHandler(EventHandler<ActionEvent> e) {
		rem34mod.setOnAction(e);
	}
	
	public void addResetModuleHandler(EventHandler<ActionEvent> e) {
		reset.setOnAction(e);
	}
	
	public void addSubmitModuleHandler(EventHandler<ActionEvent> e) {
		submit.setOnAction(e);
	}
}
