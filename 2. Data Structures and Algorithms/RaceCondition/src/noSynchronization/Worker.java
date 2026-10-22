package noSynchronization;

public class Worker extends Thread {
	
	Counter counter;
	
	Worker(Counter counter) {
		this.counter = counter;
	}
	
	public void run() {
		for(int i = 0; i < 1000; i++) {
			counter.increment();
		}
	}
}
