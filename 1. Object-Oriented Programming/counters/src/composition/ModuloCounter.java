package composition;
/**
 * A ModuloCounter maintains a count value, which can be
 * incremented and decremented and reset to zero. It also
 * has a modulo value ensuring the count stays within
 * the range 0..modulo-1 by wrapping appropriately.
 * 
 *  @author LA
 */
public class ModuloCounter {

	private Counter count;
	private int modulo;
	
	public ModuloCounter() {
		count = new Counter();
		modulo = 10;
	}
	
	public ModuloCounter(int count, int modulo) {
		this.count = new Counter(count);
		this.modulo = modulo;
	}
	
	public void setModulo(int modulo) {
		this.modulo = modulo;
	}
	
	public int getModulo() {
		return modulo;
	}
	
	public void increment() {
		if (count.getCount() == modulo-1) {
			count.setCount(0);
		} else {
			count.increment();
		}
	}
	
	public void decrement() {
		if (count.getCount() == 0) {
			count.setCount(modulo-1);
		} else {
			count.decrement();
		}
	}
	
	public int getCount() {
		return count.getCount();
	}
	
	@Override
	public String toString() {
		return this.getClass().getName() + "[count=" + count + ", modulo=" + modulo + "]";
	}
	
}
