package project_menuhesti;

import java.util.Scanner;

public class Lingkaran {
    public void LuasLingkaran(){
        double f,y;
        Scanner input = new Scanner(System.in);
        System.out.println("");
        System.out.println("Masukan jari-jari:");
        f=input.nextInt();
        y=22/7*f*f;
        System.out.println("==================================");
        System.out.println("Luas Lingkaran="+y);
    }
}
