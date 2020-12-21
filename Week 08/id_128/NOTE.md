# NOTE

路径II状态转移方程

状态数组：dp[i][j]

状态转移方程：
当i不为障碍物时 dp[i][j] = dp[i][j-1] + dp[i-1][j]

当i为障碍物时 dp[i][j] = 0


首先明确 dp 数组所存数据的含义。这步很重要，如果不得当或者不够清晰，会阻碍之后的步骤。

然后根据 dp 数组的定义，运用数学归纳法的思想，假设 dp[0...i-1]dp[0...i−1] 都已知，想办法求出 dp[i]dp[i]，一旦这一步完成，整个题目基本就解决了。

但如果无法完成这一步，很可能就是 dp 数组的定义不够恰当，需要重新定义 dp 数组的含义；或者可能是 dp 数组存储的信息还不够，不足以推出下一步的答案，需要把 dp 数组扩大成二维数组甚至三维数组。

最后想一想问题的 base case 是什么，以此来初始化 dp 数组，以保证算法正确运行。

作者：labuladong
链接：https://leetcode-cn.com/problems/longest-increasing-subsequence/solution/dong-tai-gui-hua-she-ji-fang-fa-zhi-pai-you-xi-jia/
来源：力扣（LeetCode）
著作权归作者所有。商业转载请联系作者获得授权，非商业转载请注明出处。


字符串算法
暴力法
Rabin-Karp 算法
KMP算法





两个月的刻意学习， 最重要的是学到了老师的思维和做题方法。同样的问题反复思考练习比死磕更为有效。从借鉴，吸收到可以自己可以写出来，讲出来 这样从输入到输出的过程才是真正的掌握知识。


结构
一维
array, linked list, stack, queue, deque, set, hashtable

二维
tree, graph
Binary search tree, AVL, red black tree,heap,joint set,trie, LRU

其他
bit operation, sort, string search

算法
空间换时间
升维
自顶向下的思考
找最近重复子问题
DP 找最近重复子问题 DP方程
熟悉各种算法的代码模板 形成肌肉记忆
