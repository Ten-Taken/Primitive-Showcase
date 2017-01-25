/*
Gregory Wolfe
*/

import java.awt.BorderLayout;
import javax.swing.JFrame;
import javax.swing.JPanel;
import javax.swing.JLabel;
import javax.swing.JSlider;
import javax.swing.event.ChangeEvent;
import javax.swing.event.ChangeListener;


class SlideRunner extends JFrame
{

    public SlideRunner()
    {
        super();
        mainPanel = new JPanel();
        titlePanel = new JPanel();
        slider = new JSlider();
        //initial value
        jLabel = new JLabel("50");
        setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        slider.setMajorTickSpacing(10);
        slider.setMinorTickSpacing(5);
        slider.setPaintTicks(true);
        slider.setPaintLabels(true);
        mainPanel.setLayout(new BorderLayout());
        titlePanel.add(jLabel);
        mainPanel.add(titlePanel, "North");
        mainPanel.add(slider, "Center");
        getContentPane().add(mainPanel);
        pack();
        setSize(300, 100);
        setTitle("Gregory Wolfe");
        setVisible(true);
        slider.addChangeListener(new ChangeListener() {

            public void stateChanged(ChangeEvent changeevent)
            {
                jLabel.setText((new StringBuilder()).append("").append(slider.getValue()).toString());
            }

            final SlideRunner this$0;

            
            {
                this$0 = SlideRunner.this;
            }
        }
);
    }

    private JPanel mainPanel;
    private JPanel titlePanel;
    private JSlider slider;
    private JLabel jLabel;

}
