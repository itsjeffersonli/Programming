package com.healthcareroom;

public class Main {

	public static void main(String[] args) {
		
		  Clinic d = new Clinic();
		  Surgery p = new Surgery();
		  
		  System.out.println("Hospital Room Information");
		  System.out.println();
		  d.roomAssigned();
		  System.out.println("Doctor Information");
		  d.doctorInformation();
		  System.out.println();
		  System.out.println("Patient Scheduled for today");
		  d.patientInformation();

		  System.out.println();
		  System.out.println();
		  p.roomAssigned();
		  System.out.println("Surgeon Information");
		  p.doctorInformation();
		  System.out.println();
		  System.out.println("Patient Scheduled for Surgery");
		  p.patientInformation();
	}
}
