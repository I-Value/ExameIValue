import java.io.BufferedReader;
import java.io.FileNotFoundException;
import java.io.FileReader;
import java.io.IOException;

public class Contagem {

	/**
	 * @param args
	 */
	public static void main(String[] args) {
		try {
			String line, pattern;
			FileReader txtFile = new FileReader(args[0]);
			BufferedReader txtBuffer = new BufferedReader(txtFile);

			pattern = "[a-z&&[^m]]{2} *[t|s|w|l|h]$";
			int ct = 0;
			line = txtBuffer.readLine();
			while (line != null) {
				String[] texto = line.split(" ");

				for (String string : texto) {
					if (string.matches(pattern)) {
						//System.out.println(string);
						ct++;
					}
				}
				line = txtBuffer.readLine();
			}
			System.out.println(ct);

		} catch (FileNotFoundException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		} catch (IOException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
	}

}
