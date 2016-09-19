/**
 * Created by James on 9/18/2016.
 */
public class Ship {

    public String shipName;
    public String shipYear;

    public void setShipName(String name) {
        name = this.shipName;
    }

    public void setShipYear(String year) {
        year = this.shipYear;
    }

    public String GetShipName() {
        return this.shipName;
    }

    public String GetShipYear() {
        return this.shipYear;
    }

    public Ship(String name, String year) {
        this.shipName = name;
        this.shipYear = year;
    }

    public Ship() {
        shipName = "";
        shipYear = "";
    }



    public String toString() {
        System.out.println("Shipname:     " + this.shipName + "      ShipYear: " + this.shipYear);
        return this.shipName + this.shipYear;
    }

}
