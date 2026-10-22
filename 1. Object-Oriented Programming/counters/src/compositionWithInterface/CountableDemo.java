package compositionWithInterface;

import java.util.ArrayList;
import java.util.List;

public class CountableDemo {

	public static void main(String[] args) {
		List<Countable> counters = new ArrayList<>();

		counters.add(new Counter());
		counters.add(new ModuloCounter());
		for (Countable c : counters) {
			c.increment(); c.increment();
			System.out.println("Count value: " + c.getCount());
		}
	}

}
