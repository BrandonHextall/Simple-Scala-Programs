package lib;

public class Sorting{

/**
 *  Quick sort algorithm	
 * @param arr - the array to be sorted
 * @param start - the start of the part to be sorted
 * @param end - the end of the part to be sorted
 */
public void quickSort(int[ ] arr, int start, int end){

	if (end - start >= 1){
		int pivotIndex = (start + end) / 2;

		int middle = partition(arr, start,end,arr[pivotIndex]);
		quickSort(arr, start, middle);
		quickSort(arr, middle+1, end);
	}
}

/**
 *  The partitioning part of quickSort.
 * @param arr - the array
 * @param start - the starting point of the sub-list to be sorted
 * @param end - the end point of the sub-list to be sorted
 * @param pivot - the pivot value
 * @return
 */
public int partition(int[ ] arr, int start, int end, int pivot){
	int temp;
	int i = start-1;
	int j = end+1;
	while(true){
		// Move i along from the left until an element greater than or equal to the pivot.
		do{
			i++;
		}while(arr[i] < pivot);
		
		// Move j along from the right until an element is less than or equal to the pivot.
		do{
			j--;
		}while(arr[j] > pivot);

		if (i < j){
			// Swap the values at indices i and j.
			temp = arr[i];
			arr[i] = arr[j];
			arr[j] = temp;
			
		}else{
			// The array is sorted according to the pivot so return the split point.
			return j;
		}
	}
}

/**
 * Selection sort
 * @param arr - the array to be sorted
 */
public void selectionSort(int[] arr){
	for (int i = 0; i < arr.length - 1; i++){
		// Find the minimum.
		int min = i;
		for (int j = i+1; j < arr.length; j++){
			if (arr[j] < arr[min]){
				min = j;
			}
		}
		// Swap the values.
		int temp = arr[i];
		arr[i] = arr[min];
		arr[min] = temp;
	}
}

/**
 *  Bubble sort
 * @param arr - the array to be sorted.
 */
public void bubbleSort(int[] arr){
	for (int i = arr.length - 1; i > 0; i--){
		for (int j = 1; j < i + 1; j++){
			if (arr[j-1] > arr[j]){ // The pair are the wrong way around.
				// Swap the values
				int temp = arr[j];
				arr[j] = arr[j-1];
				arr[j-1] = temp;
			}
		}
 	}
}

/**
 * Bubble sort version that stops if an iteration does no swaps.
 * @param arr - the array to be sorted.
 */
public void bubbleSort2(int[] arr){
	boolean didSwap = true;
	int i = arr.length - 1;
	while(didSwap){
		didSwap = false;
		for (int j = 1; j < i + 1; j++){
			if (arr[j-1] > arr[j]){ // The pair are the wrong way around.
				// Swap the values.
				int temp = arr[j];
				arr[j] = arr[j-1];
				arr[j-1] = temp;
				// Record that a swap occurred.
				didSwap = true;
			}
		}
		// Do the next iteration.
		i--;
 	}
}

/**
 * Insertion sort
 * @param arr - the array to be sorted.
 */
public void insertionSort(int[] arr){
	for (int i = 1; i < arr.length; i++){
		int temp = arr[i];
		int j = i;
		// Find the place to insert the value into.
		while (j > 0 && arr[j-1] > temp){
			arr[j] = arr[j-1];
			arr[j-1] = temp;
			j--;
		}
 	}
}

/**
 * Merge sort
 * @param arr - the array to be sorted
 * @param start - the start of the part to be sorted.
 * @param end - the end of the part to be sorted.
 */
public void mergeSort(int[ ] arr, int start, int end){

	if (start < end){
		int middle = (start + end) / 2;
		mergeSort(arr, start, middle);
		mergeSort(arr, middle+1, end);
		merge(arr, start, middle+1, end);
	}
}

/**
 *  The merge part of merge sort.
 * @param arr - the array to be sorted.
 * @param start - the start of the first sub-list to be merged.
 * @param middle - the start of the second sub-list to be merged.
 * @param end - the end of the second sub-list to be merged.
 */
public void merge(int[ ] arr, int start, int middle, int end){
	int[] temparr = new int[end-start+1];
	int i = start;
	int j = middle;
	int k = 0;
	// Step through each list, taking the lower item each time.
    while(i < middle && j <= end){
    	if (arr[i] <= arr[j]){
			temparr[k] = arr[i];
			i++;
		}else{
			temparr[k] = arr[j];
			j++;
		}
		k++;
	}
    // Copy all the left-over items from the first sub-list.
	while (i < middle){
		temparr[k] = arr[i];
		k++;
		i++;
	}
	// Copy all the left-over items from the second sub-list.
	while (j <= end){
		temparr[k] = arr[j];
		k++;
		j++;
	}
	// Copy the items back into the original array.
	for(int x = 0; x < temparr.length; x++){
		arr[start+x] = temparr[x];
		System.out.println(temparr[x]);
	}

}

/**
 * Converts an array of numbers into a String.
 * @param array
 * @return a String containing all the elements.
 */
public String printArray(int[] array){
	String list = "";
	for (int i = 0; i < array.length; i++){
		if (i != 0){
			list = list + "," + array[i];
		}else{
			list = "" + array[i];
		}
	}
	return list;		
}
}

