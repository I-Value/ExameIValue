import java.io.BufferedReader;
import java.io.FileNotFoundException;
import java.io.FileReader;
import java.io.IOException;

public class ContagemVerbos {

	/**
	 * @param args
	 */
	public static void main(String[] args) {
		try {
			String line, pattern, patternpp;
			FileReader txtFile = new FileReader(args[0]);
			BufferedReader txtBuffer = new BufferedReader(txtFile);

			pattern = ".*[t|s|w|l|h]$";
			patternpp = "^[t|s|w|l|h].*";
			int ctv = 0;
			int ctvpp = 0;
			line = txtBuffer.readLine();
			while (line != null) {
				String[] texto = line.split(" ");

				for (String string : texto) {
					if (string.length() >= 8) {

						if (string.matches(pattern)) {
							//System.out.println(string);
							ctv++;
							if (string.matches(patternpp)) {
								//System.out.println(string);
								ctvpp++;
							}
						}
					}
				}
				line = txtBuffer.readLine();
			}
			System.out.println(ctv);
			System.out.println(ctvpp);
		} catch (FileNotFoundException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		} catch (IOException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
	}

}
