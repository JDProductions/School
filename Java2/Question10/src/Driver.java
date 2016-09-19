/**
 * Created by James on 9/18/2016.
 */
public class Driver {
    public static void main(String[] args) {

        Ship[] shipsArray;
        shipsArray = new Ship[3];



        Ship ship = new Ship("ShipName", "1900");
        CruiseShip cruiseShip = new CruiseShip(3000, "CruiseShip");
        CargoShip cargoShip = new CargoShip(100, "CargoShip");


        shipsArray[0] = ship;
        shipsArray[1] = cargoShip;
        shipsArray[2] = cruiseShip;



        for (int i = 0; i < 3; i++) {
            shipsArray[i].toString();
        }



    }
}

