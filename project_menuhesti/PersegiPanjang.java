package project_menuhesti;

import java.util.Scanner;

public class PersegiPanjang {
    public void pp(){
        Scanner input = new Scanner(System.in);
        System.out.println("  MENGHITUNG LUAS PERSEGI PANJANG  ");
        System.out.println("*******************************");
        System.out.println("Masukan Panjang =");
        int d = input.nextInt();
        System.out.println("Masukan Lebar =");
        int e = input.nextInt();
        int z = d*e;
        System.out.println("======================================");
        System.out.println("Luas Persegi Panjang="+z);
    }
}
