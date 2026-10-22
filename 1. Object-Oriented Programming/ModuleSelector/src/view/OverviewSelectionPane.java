package view;

import javafx.event.ActionEvent;
import javafx.event.EventHandler;
import javafx.geometry.Insets;
import javafx.geometry.Pos;
import javafx.scene.control.Button;
import javafx.scene.control.TextArea;
import javafx.scene.layout.GridPane;
import javafx.scene.layout.HBox;
import javafx.scene.layout.Priority;
import model.*;

public class OverviewSelectionPane extends GridPane {
    private HBox profilebox, selresbox, savebox;
    private StudentProfile model;
    private TextArea profile, selmod, resmod;
    private Button save;

    public OverviewSelectionPane(StudentProfile model) {
    	this.model = model;
        this.setAlignment(Pos.CENTER);
        this.setPadding(new Insets(20));
        this.setVgap(10);
        
        var always = Priority.ALWAYS;

        //create HBoxes
        profilebox = new HBox(10);
        selresbox = new HBox(10);
        savebox = new HBox();

        //create TextAreas
        profile = new TextArea("Profile will appear here");
        selmod = new TextArea("Selected modules will appear here");
        resmod = new TextArea("Reserved modules will appear here");
        save = new Button("Save Overview");
        
        //sizing
        save.setPrefSize(100, 30);
        
        //padding
        profilebox.setPadding(new Insets(0, 0, 20, 0));
        savebox.setPadding(new Insets(10, 0, 0, 0));

        //scaling
        HBox.setHgrow(profile, always);
        HBox.setHgrow(selmod, always);
        HBox.setHgrow(resmod, always);
        HBox.setHgrow(profilebox, always);
        HBox.setHgrow(selresbox, always);
        GridPane.setVgrow(profile, always);
        GridPane.setVgrow(selmod, always);
        GridPane.setVgrow(resmod, always);
        GridPane.setHgrow(profilebox, always);
        GridPane.setVgrow(profilebox, always);
        GridPane.setHgrow(selresbox, always);
        GridPane.setVgrow(selresbox, always);

        //alignment
        profilebox.setAlignment(Pos.CENTER);
        selresbox.setAlignment(Pos.CENTER);
        savebox.setAlignment(Pos.CENTER);
        
        //adding nodes to container
        profilebox.getChildren().add(profile);
        selresbox.getChildren().addAll(selmod, resmod);
        savebox.getChildren().add(save);
        
        //setting immutable TextAreas
        profile.setEditable(false);
        selmod.setEditable(false);;
        resmod.setEditable(false);
        

        // Add boxes to GridPane
        this.add(profilebox, 0, 0);
        this.add(selresbox, 0, 1);
        this.add(savebox, 0, 2);
    }
    
    //gets profile textarea
    public TextArea getProfile() {
    	return profile;
    }
    
    //gets selected modules
    public TextArea getSelmod() {
    	return selmod;
    }
    
    //gets reserved modules
    public TextArea getResmod() {
    	return resmod;
    }
    //allows event handler to be added
    public void addSaveOverviewHandler(EventHandler<ActionEvent> e) {
    	save.setOnAction(e);
    }
}
