/*
 * Filename: Student.Java
 * Author: James DuBois
 * Date: Sep. 01, 2016
 * Purpose: To demonstrate an abstract class. This class will be the parent of the other class in
 * 			the project.
 */


package com.jamesrdubois;

public  abstract class Student {
	
	public static final double MINFULLTIMEHRS = 12.0;
	public static final double MAXFULLTIMEHRS = 20.0;
	public static final double MINPARTTIMEHRS = 0.5;
	public static final double MAXFPARTTIMEHRS = 11.5;
	public static final double TUITIONRATE = 240.5;
	
	protected String name;
	protected double creditHrs;
	
	public Student() {
		name = "";
		creditHrs = 0;
	}
	
	public String getName() {
		return new String(name); // Why are we newing up a string?
	}
	
	public boolean setName(String newName) {
		boolean result = true;
		
		if (newName.equals("")) {
			result = false;
			
		}
		else {
			name = new String(newName);
		}
		return result;
	}
	
	public abstract double getFinAid();
	public abstract double getTuition();
	public abstract double getCreditHrs();
	public abstract boolean setCreditHrs(double hours);
	public abstract String getStatus();
	

	
}
