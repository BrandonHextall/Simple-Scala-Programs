package usingRunnableInterface;

public class Main {
	
	public static void main(String[] args) {
		
        Thread t = new Thread(new MyRunnable());
        t.start(); // Creates and start a new thread and runs concurrently
	}
}
