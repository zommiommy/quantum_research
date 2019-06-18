function out = swap_rows(in, row1, row2)
  in([row1 row2],:)=in([row2 row1],:);
  out = in;
endfunction
