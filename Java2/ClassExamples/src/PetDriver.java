/*
 * Filename: Pet.Java
 * Author: James DuBois
 * Date: 8/30/2016
 * Purpose: To Demonstrate the structure of a class. It will use the Pet class.
 */

import java.util.Scanner;

public class PetDriver {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		Pet usersPet = new Pet("Fluffy Dog");
		System.out.println("My records on your pet are incomplete.");
		System.out.println("Here is what they currently say: ");
		System.out.println(usersPet);
		
		Scanner keyboard  = new Scanner(System.in);
		System.out.println("Please enter the pet's name: ");
		String name = keyboard.nextLine();
		System.out.println("Please enter the pet's age");
		int age = keyboard.nextInt();
		System.out.println("Please enter the pet's weight");
		double weight = keyboard.nextDouble();
		
		usersPet.set(name, age, weight);
		System.out.println("My record now says ");
		System.out.println(usersPet);
	}

}
