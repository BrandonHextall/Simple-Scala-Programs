package lib;

public class MathsThread2 extends Thread {
	Counter counter;
	
	public MathsThread2(Counter counter) {
		this.counter = counter;
	}
	
	public void run() {
		try {
			int x = counter.getValue();
			int random = (int)Math.random()*100;
			Thread.sleep(random);
			counter.setValue(x - 2);
		} catch (InterruptedException ie) {
			System.out.println(ie.getMessage());
		}
	}
}
