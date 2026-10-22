package noSynchronization;

public class Counter {
	int count = 0;
	
	void increment() {
		count++; //NOT thread-safe
	}
}
