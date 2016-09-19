/**
 * Created by James on 9/18/2016.
 */
public class CruiseShip extends Ship {
    public int maxPassengers = 0;

    public CruiseShip(int maxPassengers, String name) {
        this.maxPassengers = maxPassengers;
        this.shipName = name;
    }

    public CruiseShip() {
        maxPassengers = 0;
    }

    public CruiseShip(int passengers) {
        this.maxPassengers = passengers;
    }

    public int GetPassengers() {
        return maxPassengers;
    }

    public void SetPassengers(int passengers) {
        this.maxPassengers = passengers;
    }

    public String toString() {
        System.out.println("Shipname:     " + this.shipName + "      MaxPassengers: " + this.maxPassengers);
        return shipName + "   " + maxPassengers;
    }



}
