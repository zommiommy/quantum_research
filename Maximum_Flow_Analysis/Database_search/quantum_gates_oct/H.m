function out = H
  display("H");
  
  out = [
  1,  1; 
  1,  -1
  ];
  out = out * 1/sqrt(2);
endfunction