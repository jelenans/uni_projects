package server;

import java.io.*;
import java.net.*;
import java.util.*;

import beans.Autor;
import beans.Delo;
import beans.Galerija;
import beans.Kustos;

public class UServer {

  public static final int TCP_PORT = 9000;

  private static Vector<Kustos> kustosi = new Vector<Kustos>();

  

  private static void ucitajKustose(){
	  String red;
	  StringTokenizer tokenizer;
	  Scanner scan;
	  String ime = "";
	  String lozinka = "";
	  try {
		scan = new Scanner(new File("kustosi.txt"));
		
		while(scan.hasNext()){
			//System.out.println("SCAN");
			red = scan.next();
			tokenizer = new StringTokenizer(red,":");
			
			if(tokenizer.countTokens()==2){
				//System.out.println("2 TOKENA");
				ime = tokenizer.nextToken();
				//System.out.println("IME "+ime);
				lozinka = tokenizer.nextToken();
				//System.out.println("LOZ "+lozinka);
				Kustos k=new Kustos(ime,lozinka,false);
				kustosi.add(k);			
				
			}
		}
	} catch (FileNotFoundException e) {
		// TODO Auto-generated catch block
		e.printStackTrace();
	}
  }
  
  private static void ucitajAutore(){
	  
	  try {
	  File file= new File("autori.dat");
		if(file.exists()){
			ObjectInputStream in;
			 System.out.println("FILE_EXISTS");
				
					in = new ObjectInputStream(new FileInputStream("autori.dat"));
					Galerija.getInstance().loadAutori(in);
					in.close();
		}else {
			Galerija.getInstance().setMapaAutora(new HashMap<String,Autor>());
		}	
				} catch (FileNotFoundException e) {
					// TODO Auto-generated catch block
					e.printStackTrace();
				} catch (IOException e) {
					// TODO Auto-generated catch block
					e.printStackTrace();
				}
				
				
  }

  private static void ucitajDela(){
	  
	  try {
	  File file= new File("dela.dat");
		if(file.exists()){
			ObjectInputStream in;
			 System.out.println("FILE_EXISTS_DELA.........");
				
					in = new ObjectInputStream(new FileInputStream("dela.dat"));
					Galerija.getInstance().loadDela(in);
					in.close();
		}else {
			Galerija.getInstance().setMapaDela(new HashMap<String,Delo>());
		}	
				} catch (FileNotFoundException e) {
					// TODO Auto-generated catch block
					e.printStackTrace();
				} catch (IOException e) {
					// TODO Auto-generated catch block
					e.printStackTrace();
				}
				
				
	  
  }
  
  public static void main(String[] args) {

	ucitajKustose();
	ucitajAutore();
	ucitajDela();
	  

    try {
//    	for(Kustos k:kustosi) {
//        
//        	System.out.println("kustos_ime: "+k.getIme());
//        	if(!k.isLogged())
//        	  System.out.println("kustos_LOG: NIJE");
//        }
      // slusaj zahteve na datom portu
      ServerSocket ss = new ServerSocket(TCP_PORT);
      
      System.out.println("Server running...");
      while (true) {
        Socket sock = ss.accept();
        UServerThread st = new UServerThread(sock,kustosi);

      }
    } catch (Exception ex) {
      ex.printStackTrace();
    }
  }
  
}
