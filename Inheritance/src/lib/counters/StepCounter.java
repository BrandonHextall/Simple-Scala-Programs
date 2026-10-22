package lib.counters;

public class StepCounter extends Counter {
	
	// Fields
	private int step;
	
	// Constructors
	public StepCounter() {
		super();
		step = 1;
	}
	
	public StepCounter(int step, int count) {
		super(count);
		this.step = step;
	}
	
	@Override
	// Methods
	public void increment() {
		for (int i = 0; i < step; i ++) {
			super.increment();
		}
	}
	
	@Override
	public void decrement() {
		for (int i = 0; i < step; i ++) {
			super.decrement();
		}
	}
	
	@Override
    public String toString() {
        return this.getClass().getSimpleName() + "[count=" + getCount() + ", step=" + step + "]";
    }
}
