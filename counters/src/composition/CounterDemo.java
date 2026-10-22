package composition;

import java.util.ArrayList;
import java.util.List;

public class CounterDemo {

	public static void main(String[] args) {
		List<Counter> counters = new ArrayList<>();

		counters.add(new Counter());
		counters.add(new ModuloCounter()); //SUBSTITUTION WON'T WORK
		for (Counter c : counters) {
			c.increment(); c.increment();
			System.out.println("Count value: " + c.getCount());
		}
	}

}
