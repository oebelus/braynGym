# @param {Integer[]} prices
# @return {Integer}
def max_profit(arr)
    min_index = 0
    max_profit = 0

    arr.each_with_index do |price, i|
        if price < arr[min_index]
            min_index = i
        end

        profit = price - arr[min_index]

        if profit > max_profit && i > min_index
            max_profit = profit
        end
    end

    max_profit
end
