# 202-555-0103  202-555-0165    202-555-0150    
# 202-555-0144  202-555-0179    202-555-0159    
# 202-555-0143  202-555-0104    202-555-0138    
# 202-555-0184  202-555-0133    202-555-0154    
# 202-555-0115  202-555-0185    202-555-0153    
# 202-555-0105  202-555-0120    202-555-0129    
# 202-555-0191  202-555-0125    202-555-0175    
# 202-555-0110  202-555-0167    202-555-0149    
# 202-555-0176  202-555-0124    202-555-0152    
# 202-555-0199  202-555-0199    202-555-0181
#

File.open("b14.rb").read.gsub(/[2-9]\d{2}-\d{3}-\d{4}/) { |x|
    puts x
}
