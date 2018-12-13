public static class BallMode {				//Records the ball mode (1, 3, or 5) for other classes that need this data

	private static int balls = 0;			//Number of balls to start with

	public static void set(int mode) {		//Sets ball mode

		balls = mode;

	}

	public static int get() {				//Gets ball mode

		return balls;

	}

}
