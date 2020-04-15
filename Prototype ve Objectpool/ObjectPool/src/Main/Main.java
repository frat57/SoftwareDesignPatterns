package Main;

import java.util.concurrent.ExecutorService;  
import java.util.concurrent.Executors;  
import java.util.concurrent.TimeUnit;  
import java.util.concurrent.atomic.AtomicLong;
import java.util.Scanner;

public class Main{  
      private ObjectPool<ExportingProcess> pool;  
      private AtomicLong processNo=new AtomicLong(0);  
      public void setUp(int min, int max, int sure) {
      pool = new ObjectPool<ExportingProcess>(min, max, sure)
        {  
            protected ExportingProcess createObject()  
            {   
                return new ExportingProcess( processNo.incrementAndGet());  
            }  
        };  
    }  

    public void tearDown() {
        pool.shutdown();

    } 

    public void testObjectPool() {  
        ExecutorService executor = Executors.newFixedThreadPool(5);

        executor.execute(new ExportingTask(pool, 1));
        executor.execute(new ExportingTask(pool, 2));
        executor.execute(new ExportingTask(pool, 3));
        executor.execute( new ExportingTask(pool, 4));
        executor.execute( new ExportingTask(pool, 5));
  
        executor.shutdown();  
        try {  
            executor.awaitTermination(100, TimeUnit.SECONDS);
            } catch (InterruptedException e)  
              
              {  
               e.printStackTrace();  
              }  
    }  

    public static void main(String args[])  {   
        Main op=new Main();  
        
        Scanner scanIn = new Scanner(System.in);

        System.out.println("\n parametre için minumum değer giriniz:");
        String gelen = scanIn.nextLine();
        int min =Integer.parseInt(gelen);


        System.out.println("\n parametre için maximum değer giriniz");
        gelen = scanIn.nextLine();
        int max=Integer.parseInt(gelen);


        System.out.println("\nDogrulama araligi için sayi  giriniz");
        gelen = scanIn.nextLine();
        int interval=Integer.parseInt(gelen);

        scanIn.close();

        op.setUp(min,max,interval);
        op.tearDown();
        op.testObjectPool();  
   }   
}