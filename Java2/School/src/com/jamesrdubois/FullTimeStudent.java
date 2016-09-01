package com.jamesrdubois;

public class FullTimeStudent extends Student {

	protected final double FINAIDRATE = 0.5;
	
	public FullTimeStudent() {
		// TODO Auto-generated constructor stub
		
	}
	
	public FullTimeStudent (String studentName) {
		name = new String(studentName);
		creditHrs = 0;
	}

	@Override
	public double getFinAid() {
		return creditHrs * TUITIONRATE * FINAIDRATE;
	}

	@Override
	public double getTuition() {
		// TODO Auto-generated method stub
		return creditHrs * TUITIONRATE;
	}

	@Override
	public double getCreditHrs() {
		// TODO Auto-generated method stub
		return creditHrs;
	}

	@Override
	public boolean setCreditHrs(double hours) {
		// TODO Auto-generated method stub
		boolean result = true;
		
		if (hours < MINFULLTIMEHRS || hours > MAXFULLTIMEHRS) {
			result = false;
				
		}
		else
			creditHrs = hours;
		
		return result;
	}

	@Override
	public String getStatus() {
		// TODO Auto-generated method stub
		return "Full-Time";
	}
	
	

}
