package beans;

import java.text.ParseException;
import java.text.SimpleDateFormat;
import java.util.Calendar;
import java.util.GregorianCalendar;

public class Vreme {
public static void main(String[] args) {
	Calendar calendar = new GregorianCalendar();
	try {
		calendar.setTime((new SimpleDateFormat("dd.MM.yyyy.").parse("12.12.2001.")));
		//System.out.println(calendar.getTime());
	} catch (ParseException e) {
		// TODO Auto-generated catch block
		e.printStackTrace();
	}
	
	}
}
