/*
 * Filename: Pet.Java
 * Author: James DuBois
 * Date: 8/30/2016
 * Purpose: To Demonstrate the structure of a class. This will include constructors and overloaded methods.
 */
public class Pet {
	// Fields
	private String name;
	private int age;
	private double weight;
	
	// Methods
	public String toString() {
		return ("Name: " + name + " Age: " + age + " years " + "\nWeight: " + weight + " pounds");
	}
	
	// The first constructor has 3 parameters
	public Pet(String initialName, int initialAge, double initialWeight) {
		name = initialName;
		if ((initialAge < 0 || initialWeight < 0)) {
			System.out.println("Error: Neagative age or weight");
		}
		else {
			age = initialAge;
			weight = initialWeight;
		}// end else
		
	} // end constructor
	
	// A mutator
	public void set (String newName, int newAge, double newWeight) {
		name = newName;
		if (newAge < 0 || newWeight < 0) {
			System.out.println("Error: Negative age or weight.");
		} 
		else {
			age = newAge;
			weight = newWeight;
		}
	} // end constructor
	
	// Second constructor
	public Pet (String intialName) {
		name = intialName;
		age = 0;
		weight = 0;
	}
	
	// 3rd constructor
	
	public Pet (int initialAge) {
		name = "No name yet ";
		weight = 0;
		
		if (initialAge < 0) {
			System.out.println("Error: Negative Age.");
			System.exit(0);
		} 
	} // end third constructor
	
	// The mutator for age
	public void setAge(int newAge) {
		if (age < 0) {
			System.out.println("Error: Negative age.");
			System.exit(0);
		}
		else {
			age = newAge;
		}
	}// end setAge();
	
	// The 4th constructor with one parameter to set weight
	public Pet (double initialWeight) {
		name = "No name yet.";
		age = 0;
		if (initialWeight < 0) {
			System.out.println("Error: Negative weight.");
			System.exit(0);
		}
		else {
			weight = initialWeight;
		}
	} // end 4th constructor
	
	// The mutator for weight
	public void setWeight (int newWeight) {
		if (newWeight < 0) {
			System.out.println("Error: Negative weight");
			System.exit(0);
			
		}
	} // end setWeight()
	
	// The 5th constructor - Default Constructor
	public Pet() {
		name = "No name yet.";
		age = 0;
		weight = 0;
	}
	
	// The three Accessors or get methods
	public String getName() {
		return name;
	}
	
	public int getAge() {
		return age;
	}
	
	public double getWeight() {
		return weight;
	}
	
} // end class



































