#!/usr/bin/ruby


class NameSorter #Initiate the NameSorter class
      
  def initialize # Default Constructor
      @list = Array.new
  end
   
   # Create output, 
  def toString
      result = ""
      
      @list.each { |s| result = result + s + "\n"} # Iterate through array and create a string with a new line for each element
      return result
  end
   
  def sort() # Sort the array of names
      @list = @list.sort
  end
   
  def add(names) # add each element in an array to the @list array
      names.each {|s| @list.push s}
  end
   
  #Ruby does not need a main method, code outside of methods is run after the methods declared before it.
  # Main code goes here
   
  # Create new NameSorter Object
  merger = NameSorter.new()
   
  # Declare arrays with lists of names
  list1 = ["Adam", "Sam", "Mike"]
  list2 = ["Becky", "Chelsea", "Molly"]
  list3 = ["Connor", "John", "Scott"]
  
  merger.add(list1)
  merger.add(list2)
  merger.add(list3)
  
  puts "List after import"
  puts merger.toString()
  merger.sort()
  puts "\nList after sort"
  puts merger.toString()
   
end # end the NameSorter class


