package controls;

import javafx.collections.FXCollections;
import javafx.collections.ObservableList;
import javafx.geometry.Insets;
import javafx.geometry.Orientation;
import javafx.geometry.Pos;
import javafx.scene.control.Button;
import javafx.scene.control.CheckBox;
import javafx.scene.control.ComboBox;
import javafx.scene.control.Control;
import javafx.scene.control.Label;
import javafx.scene.control.ListView;
import javafx.scene.control.RadioButton;
import javafx.scene.control.ScrollPane;
import javafx.scene.control.Slider;
import javafx.scene.control.TextArea;
import javafx.scene.control.TextField;
import javafx.scene.control.TitledPane;
import javafx.scene.control.ToggleGroup;
import javafx.scene.control.Tooltip;
import javafx.scene.layout.Background;
import javafx.scene.layout.BackgroundFill;
import javafx.scene.layout.Border;
import javafx.scene.layout.BorderStroke;
import javafx.scene.layout.BorderStrokeStyle;
import javafx.scene.layout.CornerRadii;
import javafx.scene.layout.FlowPane;
import javafx.scene.layout.HBox;
import javafx.scene.layout.Pane;
import javafx.scene.layout.VBox;
import javafx.scene.paint.Color;
import javafx.scene.text.Font;
import javafx.util.StringConverter;

/** A scene graph of examples of FX UI controls */
public class FXControlsRootPane extends FlowPane{

	public FXControlsRootPane() {
		/*
		 * This pane is a FlowPane with left to right layout (by default),
		 * and horizontal and vertical gaps between its children (set as
		 * parameters)
		 */
		//set this FlowPane's properties
		this.setHgap(20);
		this.setVgap(20);
		this.setPrefWrapLength(600);
		this.setPadding(new Insets(20)); // create a 20px margin between
											// flowpane and the window
		this.setBackground(new Background(new BackgroundFill(Color.BISQUE, null, null)));

		
		/*=== Create and add example UI control children to this pane======*/
		
		// --------Label------------------------------
		Label lb = new Label("Hello");
		lb.setFont(Font.font("Calibri", 24));
		lb.setTextFill(Color.BLUE);
		this.getChildren().add(lb);

		// --------TextField---------------------------
		TextField tf = new TextField();
		tf.setEditable(true); // try false
		tf.setText("Type in here");
		tf.setAlignment(Pos.CENTER_RIGHT);
		tf.setTooltip(new Tooltip("An editable text field"));
		this.getChildren().add(tf);

		// --------Button------------------------------
		Button btn = new Button("Big button");
		btn.setTooltip(new Tooltip("Press me"));
		btn.setPrefSize(100, 50);
		this.getChildren().add(btn);

		// ------A Pane with a Text field and a Button----------
		HBox hbox = new HBox(8); // spacing 8
		hbox.setPadding(new Insets(10));
		Tooltip.install(hbox, new Tooltip("A HBox pane with a Textfield and a Button"));
		this.getChildren().add(hbox);
		
		//background fill
		hbox.setBackground(new Background(new BackgroundFill(Color.CYAN, new CornerRadii(10), null)));
		 // add a border
		hbox.setBorder(new Border(
				new BorderStroke(Color.RED, BorderStrokeStyle.SOLID, new CornerRadii(10), BorderStroke.MEDIUM)));
		
		hbox.getChildren().addAll(new TextField("A TextField in a Panel"), new Button("Button"));
		// ...to do...

		// --------ComboBox------------------------------
		ObservableList<String> choices 
			= FXCollections.observableArrayList (
					"A choice", "B choice", "C choice", "D choice", 
					"E choice", "F choice", "G choice", "H choice"
		);
		ComboBox<String> combo = new ComboBox<>(choices);
		combo.setVisibleRowCount(5);
		this.getChildren().add(combo);
		// ...to do...

		// --------Slider------------------------------
		// ...to do...
		Slider slider = new Slider(0, 100, 0);
		slider.setMin(-32);
		slider.setMax(212);
		slider.setOrientation(Orientation.VERTICAL);
		slider.setMinorTickCount(1);
		slider.setShowTickLabels(true);
		slider.setShowTickMarks(true);
		this.getChildren().add(slider);
		
		
		// --------ListView--------------------------------
		ObservableList<String> planets 
			= FXCollections.observableArrayList(
					"Mercury", "Venus", "Earth", "Mars", "Jupiter",
					"Saturn", "Uranus", "Neptune");// instantiate an ObservableList (see ComboBox above)
		ListView<String> listView = new ListView<String>(planets);
		listView.setMaxSize(100, 100);
		this.getChildren().add(listView);
		//...to do..

		// --------CheckBox------------------------------
		//...to do...
		CheckBox box1 = new CheckBox("one");
		box1.setSelected(true);
		CheckBox box2 = new CheckBox("two");
		box2.setIndeterminate(true);
		this.getChildren().addAll(box1, box2);
		
		// --------RadioButtons in a ToggleGroup-----------------
		//...to do...
		RadioButton b1 = new RadioButton("small");
		RadioButton b2 = new RadioButton("medium");
		RadioButton b3 = new RadioButton("large");
		ToggleGroup group = new ToggleGroup();
		b1.setToggleGroup(group);
		b2.setToggleGroup(group);
		b3.setToggleGroup(group);
		VBox box = new VBox();
		box.setFillWidth(false);
		box.setBackground(new Background(new BackgroundFill(Color.DARKGREY, null, null)));
		box.getChildren().addAll(b1, b2, b3);
		TitledPane pane = new TitledPane("Size", box);
		pane.setCollapsible(false);
		this.getChildren().add(pane);
		
		
		// --------TextArea----------------------------
		//...to do...
		TextArea txt = new TextArea("Type/nin/nhere");
		txt.setMaxSize(200, 100);
		txt.setMinSize(200, 100);
		
		this.getChildren().add(txt);
        
	}
}
