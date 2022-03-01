public static int hourglassSum(List<List<int>> arr)
    {
        List<int> HourglassTotals = new List<int>();
        // Hourglass 0 = [0,0][0,1][0,2][1,1][2,0][2,1][2,2]
        // Hourglass 1 = [0,1][0,2][0,3][1,2][2,1][2,2][2,3]
        // Hourglass 2 = [1,0][1,1][1,2][2,1][3,0][3,1]3,2]
        // Hourglass 3 = [1,1][1,2][1,3][2,2][3,1][3,2][3,3]
        // Hourglass 4 = [2,0][2,1][2,2][3,1][4,0][4,1][4,2]
        // Hourglass 5 = [2,1][2,2][2,3][3,2][4,1][4,2][4,3]
        // etc
        for (int hg_row = 0; hg_row < arr.Count-1; hg_row++) { // 0-> Total Lists in Array
            int top_row_sum;
            int middle_row_sum;
            int bottom_row_sum;
            
            for (int hg_col = 0; hg_col < arr[hg_row].Count-1; hg_col++) { // 0-> Total Integers in Array
                if (hg_col+2 <= arr[hg_row].Count-1) {
                    //Hourglass width is sufficient
                    if (hg_row+2 <= arr.Count-1) {
                        //Hourglass height is sufficient
                        top_row_sum = arr[hg_row][hg_col] + arr[hg_row][hg_col+1]+ arr[hg_row][hg_col+2];
                        middle_row_sum = arr[hg_row+1][hg_col+1];
                        bottom_row_sum = arr[hg_row+2][hg_col] + arr[hg_row+2][hg_col+1] + arr[hg_row+2][hg_col+2];
                        HourglassTotals.Add(top_row_sum+middle_row_sum+bottom_row_sum);
                    } else {
                        //Hourglass height is insufficient
                        continue;
                    }
                } else {
                    //Hourglass width is insufficient
                    continue;
                }
            }
        }
        
        if (HourglassTotals.Count > 0) {
            return HourglassTotals.Max();
        } else {
            return 0;
        }
    }
}