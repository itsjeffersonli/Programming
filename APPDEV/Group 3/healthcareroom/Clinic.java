package com.healthcareroom;

public class Clinic extends HospitalRoomInfo{

	@Override
	public void patientInformation() {
		
		System.out.println("Name: Emily Santos" + "\n" + "Age: 23" + "\n" + "Illness: Asthma" + "\n" + 
							"Procedure: General Checkup");
	}

	@Override
	public void doctorInformation() {
		final int fee = 850;
		System.out.println("Name: Dr. Ann Mariano "+ "\n" + "Specialization: Pulmonologist" + "\n" + 
							"Clinic Schedule: MWF 2:30 pm - 5:00 pm " + "\n" + "Consultation Fee: " + fee);
	}

	@Override
	public void roomAssigned() {
		System.out.println("Clinic Room 304");
	}

}
