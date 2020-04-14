package menu.actions;

import gge.model.GGEModel;
import gge.model.Project;
import gui.MainFrame;

import java.awt.event.ActionEvent;
import java.awt.event.KeyEvent;
import java.io.BufferedWriter;
import java.io.FileNotFoundException;
import java.io.FileOutputStream;
import java.io.OutputStreamWriter;
import java.io.UnsupportedEncodingException;

import javax.swing.AbstractAction;
import javax.swing.Action;
import javax.swing.ImageIcon;
import javax.swing.JFileChooser;
import javax.swing.JOptionPane;
import javax.swing.KeyStroke;
import javax.swing.filechooser.FileNameExtensionFilter;

import com.thoughtworks.xstream.XStream;
import com.thoughtworks.xstream.io.xml.DomDriver;

public class SaveProjectAction extends AbstractAction {
	
	public SaveProjectAction() {
		super();
		putValue(Action.NAME, "Save project");
		putValue(Action.SHORT_DESCRIPTION, "Save project");
		putValue(Action.SMALL_ICON, new ImageIcon("Slike/savep.jpg"));
		putValue(ACCELERATOR_KEY, KeyStroke.getKeyStroke(KeyEvent.VK_O, ActionEvent.CTRL_MASK));

	}

	@Override
	public void actionPerformed(ActionEvent arg0) {
		// TODO Auto-generated method stub
		
		/*JOptionPane.showMessageDialog(MainFrame.getInstance(), "This option will be implemented soon!",
				"Close", JOptionPane.INFORMATION_MESSAGE);
		*/
MainFrame mainFrame = null;
		
		JFileChooser choo = new JFileChooser();
		 FileNameExtensionFilter filter = new FileNameExtensionFilter(".xml", ".");
			    choo.setFileFilter(filter);
			    int returnVal = choo.showSaveDialog(choo);
			    		if(returnVal == JFileChooser.APPROVE_OPTION) {
			    String fileName = choo.getSelectedFile().getAbsolutePath();  // preuzimanje imena fajla
		     JOptionPane.showMessageDialog(mainFrame, "Odabrana datoteka: " + fileName); 
			       System.out.println("You chose to save this file: " +
			            choo.getSelectedFile().getName());
			     
		//GGEModel model = MainFrame.getInstance().getView().getGGEModel();
					Project p = null;
			       if (MainFrame.getInstance().getTree().getSelected() instanceof Project)
					{
						p = (Project)MainFrame.getInstance().getTree().getSelected();
						XStream xstream = new XStream(new DomDriver());
						xstream.registerConverter(new ProjectConverter());

						try {
							BufferedWriter out = new BufferedWriter(new OutputStreamWriter(
									new FileOutputStream(choo.getSelectedFile()), "UTF8"));
							xstream.toXML(p, out);

						} catch (UnsupportedEncodingException e) {
							e.printStackTrace();
						} catch (FileNotFoundException e) {
							e.printStackTrace();
						}
					}
			      // Project p = MainFrame.getInstance();
		
			    		}
	}

}
