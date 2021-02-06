package com.healthcareroom;

public class Surgery extends HospitalRoomInfo {

	@Override
	public void patientInformation() {
		System.out.println("Name: Fatima Andres" + "\n" + "Age: 56" + "\n" + 
							"Disease: Kidney Stones" + "\n" + "Procedure: Percutaneous Nephrolithotomy");		
	}

	@Override
	public void doctorInformation() {
		System.out.println("Name: Dr. Daniel Tiu "+ "\n" + "Specialization: Urologist " + "\n" + 
							"Surgery Schedule: Monday 1:30 pm - 4:00 pm ");	
	}

	@Override
	public void roomAssigned() {
		System.out.println("Surgery Room 1");
	}

}
