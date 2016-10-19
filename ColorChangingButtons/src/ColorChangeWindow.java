/**
 * Created by freddubois on 10/18/16.
 */

import java.awt.*;
import javax.swing.*;
import java.lang.Math;
import java.awt.event.*;
/**
 * Created by freddubois on 10/18/16.
 */

import javax.swing.JButton;


public class ColorChangeWindow extends JFrame {

    JFrame frame = new JFrame("Testing");
    Box hortzontalBox = Box.createHorizontalBox();
    JButton white = new JButton();
    JButton yellow = new JButton();


    public ColorChangeWindow(String frameName) {
        //1. Create the frame.

        frame.setName(frameName);

//2. Optional: What happens when the frame closes?
        frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);

//3. Create components and put them in the frame.
//...create emptyLabel...


//4. Size the frame.
        frame.setSize(600,400);

        IntializeGrid();
//5. Show it.
        frame.setVisible(true);
    }

    public void IntializeGrid() {
        frame.setLayout(new GridLayout(1, 3));
                white.setText("White");
                yellow.setText("Yellow");
                frame.add(white);
                frame.add(yellow);
                hortzontalBox.setOpaque(true);
                //hortzontalBox.add(new JTextField("Box"));
                frame.add(hortzontalBox);




    }

    public void IsWhiteButtonPressed()
    {
        JButton showDialogButton = new JButton("Text Button");
        white.addActionListener(new ActionListener()
        {
            public void actionPerformed(ActionEvent e)
            {
                // display/center the jdialog when the button is pressed
                hortzontalBox.setBackground(Color.WHITE);
                System.out.println("White");

            }
        });


    }

    public void IsYellButtonPressed()
    {
        yellow.addActionListener(new ActionListener()
        {
            public void actionPerformed(ActionEvent e)
            {

                hortzontalBox.setBackground(Color.YELLOW);
                System.out.println("Yellow");

            }
        });

    }

    public Box GetHorizontalBox() {
        return hortzontalBox;
    }

    public JButton GetWhiteButton() {
        return white;
    }

}
