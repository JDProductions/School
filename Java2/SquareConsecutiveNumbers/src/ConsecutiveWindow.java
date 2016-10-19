/**
 * Created by freddubois on 10/18/16.
 */

import java.awt.Frame;
import javax.swing.*;
import java.awt.BorderLayout;
import java.lang.Math;
/**
 * Created by freddubois on 10/18/16.
 */

import java.awt.GridLayout;
import javax.swing.JButton;


public class ConsecutiveWindow extends JFrame {

    private int n = 10;
    private int coulmns = (int)Math.pow(n,2);
    JFrame frame = new JFrame("Testing");

    public ConsecutiveWindow(String frameName) {
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
        frame.setLayout(new GridLayout(n, coulmns));

    int counter = 1;
        for (int t = 0; t < n; t++) {


            for (int i = 0; i < n; i++) {
                frame.add(new JButton(String.valueOf(counter)));
                counter++;

            }
        }

    }

    public void SetIntegerN(int n)
    {
        this.n = n;
    }

}
