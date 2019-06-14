function out = IC(in)
  size = rows(in);
  out = blkdiag(in,eye(size));
endfunction
