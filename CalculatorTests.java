import static org.junit.jupiter.api.Assertions.*;

import org.junit.jupiter.api.Test;

class CalculatorTests {

	@Test
	void addingTest() {
		assertEquals(Calculator.addThem(1, 1), 2.0);
	}
	
	@Test
	void subtractTest() {
		assertEquals(Calculator.subtractThem(1, 1), 0.0);
	}
	
	@Test
	void multiplyTest() {
		assertEquals(Calculator.multiplyThem(2, 2), 4.0);
	}
	
	@Test
	void divideTest() {
		assertEquals(Calculator.divideThem(10, 5), 2.0);
	}

}
