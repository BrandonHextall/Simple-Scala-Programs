package lib;
import java.util.concurrent.*;

public class MathsThread1 extends Thread {
	private Semaphore mutex;
	private Counter counter;
	//Counter counter;
	
	public MathsThread1(Counter c, Semaphore s) {
		counter = c;
		mutex = s;
	}
	
	public void run() {
		try {
			mutex.acquire();
			int x = counter.getValue();
			int random = (int)Math.random()*100;
			Thread.sleep(random);
			counter.setValue(x + 5);
		} catch(InterruptedException ie) {
			System.out.println(ie.getMessage());
		} finally {
			mutex.release();
		}
	}
}
