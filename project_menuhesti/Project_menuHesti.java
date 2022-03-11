package project_menuhesti;

import java.util.Scanner;

public class Project_menuHesti {

    public static void main(String[] args) {
        
        String ulg = "y";
        while(ulg.equals("y"))
        {
            System.out.println("");
            Scanner input = new Scanner(System.in);
            String ul="",lagi;
            System.out.println("**********SELAMAT DATANG**********");
            System.out.println("");
            System.out.println("        MENU UTAMA       ");
            System.out.println("1. Luas Persegi Panjang");
            System.out.println("2. Luas Lingkaran");
            System.out.println("3. Luas Segitiga");
            System.out.println("4. Keluar");
            System.out.println("===============================================");
            System.out.println("Pilihan[1/2/3/4]=");
            int pilih = input.nextInt();
            System.out.println("===============================================");
            
            switch(pilih){
                case 1:{
                    System.out.println("Anda memilih cara menghitung Luas Persegi Panjang");
                    PersegiPanjang a=new PersegiPanjang();
                    a.pp();
                    break;
                }
                case 2:{
                    System.out.println("Anda memilih cara menghitung Luas Lingkaran");
                    Lingkaran b=new Lingkaran();
                    b.LuasLingkaran();
                    break;
                }
                case 3:{
                    System.out.println("Anda memilih cara menghitung Luas Segitiga");
                    Segitiga c=new Segitiga();
                    c.LuasSegitiga();
                    break;
                }
                default:{
                    System.out.println("Warning!! Pilihan tidak tersedia!!");
                }
            }
            System.out.println("=================================================");
            System.out.println("Apakah Anda ingin mengulang(y/t)?");
            ulg = input.next();
        }
    }
}
