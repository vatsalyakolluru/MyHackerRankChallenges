#!/bin/ruby

a = gets.strip.chars.to_a
b = gets.strip.chars.to_a

def looparray(a,b)
    for a_item in a
        for b_item in b
            if a_item == b_item 
                a.delete_at(a.find_index(a_item));
                b.delete_at(b.find_index(b_item)); 
                looparray(a,b);
                break;
            end
        end
    end  
end

if(a.length < 1 || a.length > 10000 || b.length < 1 || b.length > 10000)
    print "error"
    return;
end
looparray(a,b)
print a.length+b.length