#{
You can't find both A and B, given a K, because there could be many possible A's 
and B's to produce a certain kron matrix, K. Thus, alongwith K, you need either 
A or B to get the remaining input B or A respectively.

Case #1 Given A and K (kron matrix), you can find B with -

B = K(1:size(K,1)/size(A,1),1:size(K,2)/size(A,2))./A(1)
Case #2 Given B and K (kron matrix), you can find A with -

A = K(1:size(B,1):end,1:size(B,2):end)./B(1)
Thus, if not the entire other input, you would at least need to know the size of 
it and one of the elements of it, preferably the first element.

Function Code
You can very easily convert that to a function code for an easy plug-n-play usage -

%// INVERSE_KRON   Inverse of Kronecker tensor product to find one of the inputs.
%   // INVERSE_KRON(K,ARRAY,INPUT_ID) finds one of the inputs used for calculating the
%   // Kronecker tensor product given the other input and the ID of that other input.
%   // Thus, if K was obtained with K = KRON(A,B), one must use -
%       // A = INVERSE_KRON(K,B,2) to find A, and
%       // B = INVERSE_KRON(K,A,1) to find B.
#}

function out = inverse_kron(K,array,input_id)

switch input_id
    case 1
        temp_out = K(1:size(K,1)/size(array,1),1:size(K,2)/size(array,2))./array(1);
        verification_matrix = kron(array, temp_out);
    case 2
        temp_out = K(1:size(array,1):end,1:size(array,2):end)./array(1);
        verification_matrix = kron(temp_out,array);
    otherwise
        display('The Input ID must be either 1 or 2')
        return;
end

if isequal(verification_matrix, K)
  out = temp_out;
else
  display('Decomposition not possible')
endif

return;

#{
Typical use case would look like this -

K = kron(A,B);          %// Get kron product
A = inverse_kron(K,B,2) %// Recover A
B = inverse_kron(K,A,1) %// Recover B
#}