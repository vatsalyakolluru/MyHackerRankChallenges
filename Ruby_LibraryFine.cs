#!/bin/ruby

d1,m1,y1 = gets.strip.split(' ')
d1 = d1.to_i
m1 = m1.to_i
y1 = y1.to_i
d2,m2,y2 = gets.strip.split(' ')
d2 = d2.to_i
m2 = m2.to_i
y2 = y2.to_i

if ((d1 < 1) || (d1 > 31) || (d2 < 1) || (d2 > 31) || (y1 < 1) || (y1 > 3000) || (y2 < 1) || (y2 > 3000) || (m1 < 1) || (m1 > 12) || (m2 < 1)|| (m2 > 12))
    print "Error"
    return
end
if y1 < y2
    print 0
    return
end 
if y1>y2
   print 10000
    return
end 
if m1 < m2
    print 0
    return
end
if m1>m2
    print 500*(m1-m2)
    return
 end 
if d1>d2
    print 15*(d1-d2)
    return
end 
print 0