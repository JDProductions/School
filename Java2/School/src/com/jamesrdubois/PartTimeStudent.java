package com.jamesrdubois;

public class PartTimeStudent extends Student {

	protected final double FINAIDRATE = 0.5;
	
	public PartTimeStudent() {
		// TODO Auto-generated constructor stub
		
	}
	
	public PartTimeStudent (String studentName) {
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
		
		if (hours < MINPARTTIMEHRS || hours > MAXFPARTTIMEHRS) {
			result = false;
				
		}
		else
			creditHrs = hours;
		
		return result;
	}

	@Override
	public String getStatus() {
		// TODO Auto-generated method stub
		return "Part-Time";
	}
	
	

}
