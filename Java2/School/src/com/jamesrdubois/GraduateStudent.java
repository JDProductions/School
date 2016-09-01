package com.jamesrdubois;

public class GraduateStudent extends FullTimeStudent{
	public static final double MINFULLTIMEHRS = 4.0;
	public static final double MAXFULLTIMEHRS = 8.0;
	public static final double TUITIONRATE = 350.0;
	private final double FINAIDRATE = 0.9;
	
	public GraduateStudent() {
		
	}
	
	public GraduateStudent (String studentName) {
		name = new String(studentName);
		creditHrs = 0;
	}
	
	public boolean setCreditHrs(double hrs) {
		boolean result = true;
		
		if (hrs < MINFULLTIMEHRS || hrs > MAXFULLTIMEHRS) {
			result = false;
		}
		else
			creditHrs = hrs;
		
		return result;
	}
	
	public String getStatus() {
		return "Graduate Student";
	}
	
}
