function out = CSWAP
  out = eye(8);
  out = swap_rows(out,6,7);
endfunction

function out = swap_rows(in, row1, row2)
  in([row1 row2],:)=in([row2 row1],:);
  out = in;
endfunction
