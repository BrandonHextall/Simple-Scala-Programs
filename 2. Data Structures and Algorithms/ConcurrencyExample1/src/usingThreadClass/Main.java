package usingThreadClass;

public class Main {
	
    public static void main(String[] args) throws InterruptedException {
    	
        MyThread t = new MyThread();
        t.start(); // Creates and start a new thread and runs concurrently
    }
}
