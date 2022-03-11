package project_menuhesti;

import java.util.Scanner;

public class MenuPilihan_Hesti {
    public static void main(String[] args){
        Scanner input = new Scanner(System.in);
        System.out.print("Masukan Jumlah Data : ");
        int n = input.nextInt();
        
        String nama[]=new String[n];
        String peserta[]=new String[n];
        String jurusan[]=new String[n];
        int bin[]=new int[n];
        int big[]=new int[n];
        int mat[]=new int[n];
        int kejuruan[]=new int[n];
        double rata, jum;
        
        for(int i=0; i<n; i++){
            System.out.println("Siswa Ke : "+(i+1)+".");
            System.out.print("Nomor : ");
            nama[i]=input.next();
            
            System.out.print("Nama peserta : ");
            peserta[i]=input.next();
            
            System.out.print("Jurusan : ");
            jurusan[i]=input.next();
            
            System.out.print("Nilai BIN: ");
            bin[i]=input.nextInt();
            
            System.out.print("Nilai BIG: ");
            big[i]=input.nextInt();
        
            System.out.print("nilai MAT: ");
            mat[i]=input.nextInt();
            
            System.out.print("nilai Kejuruan: ");
            kejuruan[i]=input.nextInt();
            
        }
        System.out.println("======================");
        System.out.println("DAFTAR NILAI MAHASISWA");
        System.out.println("======================");
        System.out.println("No  ||   Nomer_Peserta   ||   Nama_Peserta   ||  Jurusan  ||   Nilai BIN  ||  Nilai BIG  ||  Nilai MAT  ||  Rata-Rata   ||   Jumlah");
        
        
            
        for (int i=0; i<n;i++){
            jum = bin[i]+big[i]+mat[i]+kejuruan[i];
            rata=jum/4;
            System.out.println((i+1)+"        "+nama[i]+"           "+peserta[i]+" "+peserta[i]+"        "+jurusan[i]+"       "+bin[i]+"       "+big[i]+"       "+mat[i]+"      "+kejuruan[i]+"      "+rata+"     "+jum);
        }
    }
}
