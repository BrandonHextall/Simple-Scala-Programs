package inheritance;
/**
 * A ModuloCounter maintains a count value, which can be
 * incremented and decremented and reset to zero. It also
 * has a modulo value ensuring the count stays within
 * the range 0..modulo-1 by wrapping appropriately.
 * 
 *  @author LA
 */
public class ModuloCounter extends Counter {

	private int modulo;
	
	public ModuloCounter() {
		super();
		modulo = 10;
	}
	
	public ModuloCounter(int count, int modulo) {
		super(count);
		this.modulo = modulo;
	}
	
	public void setModulo(int modulo) {
		this.modulo = modulo;
	}
	
	public int getModulo() {
		return modulo;
	}
	
	@Override 
	public void setCount(int count) {
		if (count < 0) {
			super.setCount(0);
		} else if (count >= modulo) {
			super.setCount(modulo-1);
		} else {
			super.setCount(count);
		}

	}
	
	@Override
	public void increment() {
		if (super.getCount() == modulo-1) {
			super.setCount(0);
		} else {
			super.increment();
		}
	}
	
	@Override 
	public void incrementBy(int amount) {
		 super.setCount( (super.getCount() + amount) % modulo );
	}
	
	@Override 
	public void decrement() {
		if (super.getCount() == 0) {
			super.setCount(modulo-1);
		} else {
			super.decrement();
		}
	}
	
	@Override 
	public void decrementBy(int amount) {
		super.setCount( (super.getCount() + (modulo - (amount % modulo))) % modulo );
	}
	
	
	@Override
	public String toString() {
		return super.toString() + "[modulo=" + modulo + "]";
	}
	
}
