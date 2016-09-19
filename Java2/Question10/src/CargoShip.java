/**
 * Created by James on 9/18/2016.
 */
public class CargoShip extends Ship {
    public int cargoCapacity = 0;

    public CargoShip(int cargoCapacity, String name) {
        this.cargoCapacity = cargoCapacity;
        this.shipName = name;
    }

    public CargoShip() {
        cargoCapacity = 0;
    }

    public CargoShip(int capacity) {
        this.cargoCapacity = capacity;
    }

    public void SetCapacity(int cargoCapacity) {
        this.cargoCapacity = cargoCapacity;
    }

    public int GetCargoCapacity() {
        return this.cargoCapacity;
    }

    public String toString() {
        System.out.println("Shipname:     " + this.shipName + "      CargoCapacity: " + this.cargoCapacity);
        return shipName + "   " + cargoCapacity;
    }


}
