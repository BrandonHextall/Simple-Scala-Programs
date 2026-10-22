package lib;
import java.util.concurrent.*;

public class MathsThread2 extends Thread {
	private Semaphore mutex;
	private Counter counter;
	//Counter counter;
	
	public MathsThread2(Counter c, Semaphore s) {
		counter = c;
		mutex = s;
	}
	
	public void run() {
		try {
			mutex.acquire();
			int x = counter.getValue();
			int random = (int)Math.random()*100;
			Thread.sleep(random);
			counter.setValue(x - 2);
		} catch(InterruptedException ie) {
			System.out.println(ie.getMessage());
		} finally {
			mutex.release();
		}
	}
}
