package project_menuhesti;

import java.util.Scanner;

public class Latihan2_14Januari {

    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);
        
        int i, jum=0;
        String[] Nomor = new String[100];
        String[] Nama = new String[100];
        String[] Jurusan = new String[100];
        int[] Bin = new int[100];
        int[] Big = new int[100];
        int[] Mat = new int[100];
        int[] Kejuruan = new int[100];
        double rata;
        
        System.out.println("");
        System.out.println("======= MENU PILIHAN ========");
        System.out.println("");
        System.out.println("=============================");
        System.out.println("1. Menghitung Data Siswa");
        System.out.println("2. Exit");
        System.out.println("");
        
        System.out.print("ANDA PILIH NOMOR : ");
        int pil=input.nextInt();
        switch(pil){
        case 1 :{
        System.out.println("MENGHITUNG NILAI SISWA (ARRAY)");
        System.out.print("MASUKAN JUMLAH SISWA : ");
        int j=input.nextInt();
        for(i=1; i<=j; i++)
        {
        System.out.print(i+". ");

           System.out.print("Nomor Peserta  : ");
           Nomor[i]=input.next();
           System.out.print("Nama         : ");
           Nama[i]=input.next();
           System.out.print("Jurusan      : ");
           Jurusan[i]=input.next();
           System.out.print("Nilai BIN         : ");
           Bin[i]=input.nextInt();
           System.out.print("Nilai BIG         : ");
           Big[i]=input.nextInt();
           System.out.print("Nilai MTK         : ");
           Mat[i]=input.nextInt();
           System.out.print("Nilai KEJURUAN    : ");
           Kejuruan[i]=input.nextInt();
           
           jum = Bin[i]+Big[i]+Mat[i]+Kejuruan[i];
           rata=jum/4;
           System.out.println("   NILAI RATA  : "+rata);
           System.out.println("  JUMLAH      : "+jum);
           System.out.println("");
        }
        for(i=1;i<j;i++){
            System.out.print(Nomor[i]+"   ");
            System.out.print(Nama[i]+"    ");
            System.out.print(Jurusan[i]+"    ");
            System.out.print(Bin[i]+"    ");
            System.out.print(Big[i]+"   ");
            System.out.print(Mat[i]+"   ");
            System.out.print(Kejuruan[i]+"   ");
        }
        break;
        }
        case 2:{
          System.exit(0);
          break;
        }
          default:System.exit(0);
        }
    }
}
