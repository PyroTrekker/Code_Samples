SortedList := Object clone; // Clone a new SortedList object

  SortedList nmList := List clone;
  
  SortedList toString := method( // Method to create output
    result := "";
    for(s, 1, nmList size, result := result + nmList at(s) + "\n");
    result print;
  );
  
  SortedList nmList append("Dave","Sean","lol");
  SortedList toString;