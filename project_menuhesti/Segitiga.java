package project_menuhesti;

import java.util.Scanner;

public class Segitiga {
    public void LuasSegitiga(){
        Scanner input = new Scanner(System.in);
        System.out.println("Masukan Alas:");
        double f=input.nextInt();
        System.out.println("Masukan Tinggi:");
        double g=input.nextInt();
        double y=(f*g)/2;
        System.out.println("===========================");
        System.out.println("");
        System.out.println("Laus Segitiga="+y);
    }
}
