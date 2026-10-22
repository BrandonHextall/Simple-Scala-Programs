package view;

import javafx.scene.control.Button;
import javafx.scene.control.Label;
import javafx.scene.control.ListView;
import javafx.scene.layout.GridPane;
import javafx.scene.layout.HBox;
import javafx.scene.layout.Priority;
import javafx.scene.layout.VBox;
import model.Module;
import javafx.event.ActionEvent;
import javafx.event.EventHandler;
import javafx.geometry.Insets;
import javafx.geometry.Pos;

public class ReserveModulesPane extends VBox {
	private Reserve txtu34, txtr34;
	private Label u34title, r34title, r1op;
	private Button add, rem, con;
	
	public ReserveModulesPane() {
		this.setAlignment(Pos.CENTER);
		
		//setting VBox and HBox
		GridPane 	u34box = new GridPane(),
					r34box = new GridPane();
		HBox 	modulebox = new HBox(),
				reservebox = new HBox();
		
		//creating labels
		u34title = new Label("Unselected Block 3/4 modules");
		r34title = new Label("Reserve Block 3/4 modules");
		r1op = new Label("Reserve one optional module");
		
		//creating ListViews
		txtu34 = new Reserve();
		txtr34 = new Reserve();
		
		//creating buttons
		add = new Button("Add");
		rem = new Button("Remove");
		con = new Button("Confirm");
		
		//scaling
		GridPane.setHgrow(txtu34, Priority.ALWAYS);
		GridPane.setVgrow(txtu34, Priority.ALWAYS);
		GridPane.setHgrow(txtr34, Priority.ALWAYS);
		GridPane.setVgrow(txtr34, Priority.ALWAYS);
		GridPane.setHgrow(reservebox, Priority.ALWAYS);
		HBox.setHgrow(u34box, Priority.ALWAYS);
		HBox.setHgrow(r34box, Priority.ALWAYS);
		HBox.setHgrow(reservebox, Priority.ALWAYS);
		VBox.setVgrow(modulebox, Priority.ALWAYS);
		
		//positioning
		reservebox.setAlignment(Pos.CENTER);
		
		//sizing
		u34box.setPrefHeight(200);
		r34box.setPrefHeight(200);
		add.setPrefSize(80, 20);
		rem.setPrefSize(80, 20);
		con.setPrefSize(80, 20);
		
		//padding
		modulebox.setPadding(new Insets(30, 30, 20, 30));
		reservebox.setPadding(new Insets(10, 30, 30, 30));
		
		//spacing
		modulebox.setSpacing(20);
		reservebox.setSpacing(20);
		
		//adding nodes to containers
		u34box.add(u34title, 0, 0);
		u34box.add(txtu34, 0, 1);
		r34box.add(r34title, 0, 0);
		r34box.add(txtr34, 0, 1);
		modulebox.getChildren().addAll(u34box, r34box);
		reservebox.getChildren().addAll(r1op, add, rem , con);
		
		//adding containers to main VBox
		this.getChildren().addAll(modulebox, reservebox);
	}
	
	public class Reserve extends ListView<Module> {
		public Reserve() {
			super();
		}
	}
	
	//get unselected block 3/4 ListView
	public ListView<Module> getUns34Modules() {
		return txtu34;
	}
	
	//get reserved block 3/4 ListView
	public ListView<Module> getRes34Modules() {
		return txtr34;
	}
	
	//allows event handlers to be added
	public void addAddResModuleHandler(EventHandler<ActionEvent> e) {
		add.setOnAction(e);
	}
	
	public void addRemResModuleHandler(EventHandler<ActionEvent> e) {
		rem.setOnAction(e);
	}
	
	public void addConResModuleHandler(EventHandler<ActionEvent> e) {
		con.setOnAction(e);
	}
	
}
