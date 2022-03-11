/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Main.java to edit this template
 */
package project_menuhesti;
import java.util.Scanner;
/**
 *
 * @author ASUS
 */
public class Latihan_tabel {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // TODO code application logic here
        Scanner input=new Scanner(System.in);
        System.out.print("Masukkan Jumlah Data : ");
        int n=input.nextInt();
        
        String nama[]=new String[n];
        String peserta[]=new String[n];
        String jurusan[]=new String[n];
        int bin[]=new int[n];
        int big[]=new int[n];
        int mat[]=new int[n];
        
        for(int i=0; i<n; i++){
            System.out.println("Mahasiswa Ke : " +(i+1));
            System.out.print("Nomer : ");
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
            
        }
        System.out.println("DAFTAR NILAI MAHASISWA");
        System.out.println("======================");
        System.out.println("No   Nomer_Peserta   Nama_Peserta   Jurusan   Nilai BIN   Nilai BIG  Nilai MAT");
        
        for (int i=0; i<n;i++){
            System.out.println((i+1)+"    "+nama[i]+"         "+peserta[i]+"          "+jurusan[i]+"         "+bin[i]+"         "+big[i]+"       "+mat[i]);
        }
    }
    
}
