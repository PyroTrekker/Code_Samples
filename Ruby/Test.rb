#!/usr/bin/ruby


class Person
def name
puts "Joe"
end
def self.method_missing
puts "Method not defined"
end
end

p = Person.new
puts p.age